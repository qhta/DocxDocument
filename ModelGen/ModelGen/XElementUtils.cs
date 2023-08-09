namespace ModelGen;
public static class XElementUtils
{
  /// <summary>
  /// Short text description of this element.
  /// </summary>
  public static string? GetText(this XElement xElement)
  {
    if (xElement.HasElements)
      return String.Join(" ", xElement.Elements().Select(item => GetText(item)));
    return xElement.Value;
  }
}
