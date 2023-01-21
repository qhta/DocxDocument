namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Row.
/// </summary>
public static class MatrixRowConverter
{
  private static Collection<DMMath.Base> GetBases(DXMath.MatrixRow openXmlElement)
  {
    var collection = new Collection<DMMath.Base>();
    foreach (var item in openXmlElement.Elements<DXMath.Base>())
    {
      var newItem = DMXMath.BaseConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetBases(DXMath.MatrixRow openXmlElement, Collection<DMMath.Base>? value)
  {
    openXmlElement.RemoveAllChildren<DXMath.Base>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXMath.BaseConverter.CreateOpenXmlElement<DXMath.Base>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMMath.MatrixRow? CreateModelElement(DXMath.MatrixRow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.MatrixRow();
      value.Bases = GetBases(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.MatrixRow? value)
    where OpenXmlElementType: DXMath.MatrixRow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBases(openXmlElement, value?.Bases);
      return openXmlElement;
    }
    return default;
  }
}
