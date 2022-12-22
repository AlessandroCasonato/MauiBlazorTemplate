namespace MauiBlazorTemplate.Core
{
    public static class StaticUtilities
    {
        public enum CompanyDimension
        {
            None, 
            Startup,
            Small,
            Medium,
            Large,
            Multinational
        }
        public static string? CompanyDimensionToString(CompanyDimension companyDimension)
        {
            switch (companyDimension)
            {
                case CompanyDimension.Startup:
                    return "Startup";
                case CompanyDimension.Small:
                    return "Small";
                case CompanyDimension.Medium:
                    return "Medium"; 
                case CompanyDimension.Large:
                    return "Large";
                case CompanyDimension.Multinational:
                    return "Multinational";
                case CompanyDimension.None:
                default:
                    return null;
            }
        }
    }
}
