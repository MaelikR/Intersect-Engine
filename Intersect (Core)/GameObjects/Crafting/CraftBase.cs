using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Intersect.GameObjects.Conditions;

using Intersect.Models;

using Newtonsoft.Json;

namespace Intersect.GameObjects.Crafting
{

    public class CraftBase : DatabaseObject<CraftBase>, IFolderable
    {

        [NotMapped] public List<CraftIngredient> Ingredients = new List<CraftIngredient>();
        [NotMapped] public ConditionLists CraftRequirements = new ConditionLists();

        [JsonConstructor]
        public CraftBase(Guid id) : base(id)
        {
            Name = "New Craft";
        }

        //Parameterless constructor for EF
        public CraftBase()
        {
            Name = "New Craft";
        }

        [JsonIgnore]
        [Column("Ingredients")]
        public string IngredientsJson
        {
            get => JsonConvert.SerializeObject(Ingredients, Formatting.None);
            protected set => Ingredients = JsonConvert.DeserializeObject<List<CraftIngredient>>(value);
        }

        [JsonProperty(Order = -4)]
        public Guid ItemId { get; set; }

        [JsonProperty(Order = -3)]
        public int Quantity { get; set; } = 1;

        [JsonProperty(Order = -2)]
        public int Time { get; set; }

        [Column("SuccessRate")]
        public int SuccessRate { get; set; } = 100;

        [Column("CraftEvent")]
        public Guid CraftEventId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public Events.EventBase CraftEvent
        {
            get => Events.EventBase.Get(CraftEventId);
            set => CraftEventId = value?.Id ?? Guid.Empty;
        }

        [Column("CraftRequirements")]
        [JsonIgnore]
        public string JsonCraftRequirements
        {
            get => CraftRequirements.Data();
            set => CraftRequirements.Load(value ?? "[]");
        }

        /// <inheritdoc />
        public string Folder { get; set; } = "";

    }

    public class CraftIngredient
    {

        public Guid ItemId;

        public int Quantity = 1;

        public CraftIngredient(Guid itemId, int quantity)
        {
            ItemId = itemId;
            Quantity = quantity;
        }

        public ItemBase GetItem()
        {
            return ItemBase.Get(ItemId);
        }

    }

}
