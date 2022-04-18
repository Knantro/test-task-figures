namespace Figures; 

internal static class Messages {
    internal const string TriangleRuleErrorMessage = "Cannot create triangle due to invalid arguments was passed. " +
                                                     "Triangle should correspond the rule: The sum of any two sides should be greater than the third side.";

    internal static string FieldShouldBePositiveValueMessage(string fieldName) =>
        $"Field {fieldName} cannot be less or equal 0.";
}