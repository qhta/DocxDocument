namespace DocumentModel.OpenXml;

public static class NumericValueConverter
{
  #region SimpleValue
  public static DM.NumericValue? GetValue(OpenXmlLeafTextElement? element)
  {
    if (element?.Text == null)
      return null;
    return new DM.NumericValue(element.Text);
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(String? value)
    where OpenXmlElementType : OpenXmlLeafTextElement, new()
  {
    if (value == null) return null;
    return new OpenXmlElementType { Text = value };
  }
  #endregion
}