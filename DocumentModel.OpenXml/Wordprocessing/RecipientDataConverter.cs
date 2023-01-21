namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Data About Single Data Source Record.
/// </summary>
public static class RecipientDataConverter
{
  /// <summary>
  /// Record Is Included in Mail Merge.
  /// </summary>
  private static Boolean? GetActive(DXW.RecipientData openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Active>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetActive(DXW.RecipientData openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Active>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Active();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Index of Column Containing Unique Values for Record.
  /// </summary>
  private static UInt32? GetColumnIndex(DXW.RecipientData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.ColumnIndex>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetColumnIndex(DXW.RecipientData openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ColumnIndex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ColumnIndex{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Unique Value for Record.
  /// </summary>
  private static Byte[]? GetUniqueTag(DXW.RecipientData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.UniqueTag>();
    if (itemElement != null)
      return DMX.HexBinaryConverter.GetValue(itemElement);
    return null;
  }
  
  private static void SetUniqueTag(DXW.RecipientData openXmlElement, Byte[]? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UniqueTag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.HexBinaryConverter.CreateOpenXmlElement<DXW.UniqueTag>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.RecipientData? CreateModelElement(DXW.RecipientData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RecipientData();
      value.Active = GetActive(openXmlElement);
      value.ColumnIndex = GetColumnIndex(openXmlElement);
      value.UniqueTag = GetUniqueTag(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.RecipientData? value)
    where OpenXmlElementType: DXW.RecipientData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetActive(openXmlElement, value?.Active);
      SetColumnIndex(openXmlElement, value?.ColumnIndex);
      SetUniqueTag(openXmlElement, value?.UniqueTag);
      return openXmlElement;
    }
    return default;
  }
}
