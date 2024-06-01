
namespace DexCompany
{
    public struct Currency
    {
    public decimal Value { get; set; } 
    public string Code { get; set; }

        public void UpdateValue(decimal newValue)
        {
            Value = newValue;
        }
    }
}
