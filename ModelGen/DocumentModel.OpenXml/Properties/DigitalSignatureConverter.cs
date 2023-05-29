namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Digital Signature.
/// </summary>
public static class DigitalSignatureConverter
{
  /// <summary>
  /// Binary Blob.
  /// </summary>
  private static String? GetVTBlob(DXExtProps.DigitalSignature openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTBlob>()?.Text;
  }
  
  private static bool CmpVTBlob(DXExtProps.DigitalSignature openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTBlob>()?.Text == value;
  }
  
  private static void SetVTBlob(DXExtProps.DigitalSignature openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTBlob>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTBlob { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Properties.DigitalSignature? CreateModelElement(DXExtProps.DigitalSignature? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Properties.DigitalSignature();
      value.VTBlob = GetVTBlob(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXExtProps.DigitalSignature? openXmlElement, DMProps.DigitalSignature? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVTBlob(openXmlElement, value.VTBlob, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMProps.DigitalSignature value)
    where OpenXmlElementType: DXExtProps.DigitalSignature, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXExtProps.DigitalSignature openXmlElement, DMProps.DigitalSignature value)
  {
    SetVTBlob(openXmlElement, value?.VTBlob);
  }
}
