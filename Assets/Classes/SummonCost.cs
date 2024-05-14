using Assets.Enum;

namespace Assets.Classes
{
    public class SummonCost
    {
        public int CostAmount { get; set; }
        public ResourceType CostResource { get; set; }

        public SummonCost()
        {

        }

        public SummonCost(int costAmount, ResourceType costResource)
        {
            CostAmount = costAmount;
            CostResource = costResource;
        }
    }
}
