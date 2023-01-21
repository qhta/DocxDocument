namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Table Grid Column Definitions.
/// </summary>
public static class TableGridChangeConverter
{
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.TableGridChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.TableGridChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Table Grid.
  /// </summary>
  private static DMW.PreviousTableGrid? GetPreviousTableGrid(DXW.TableGridChange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PreviousTableGrid>();
    if (itemElement != null)
      return DMXW.PreviousTableGridConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPreviousTableGrid(DXW.TableGridChange openXmlElement, DMW.PreviousTableGrid? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousTableGrid>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousTableGridConverter.CreateOpenXmlElement<DXW.PreviousTableGrid>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableGridChange? CreateModelElement(DXW.TableGridChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableGridChange();
      value.Id = GetId(openXmlElement);
      value.PreviousTableGrid = GetPreviousTableGrid(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableGridChange? value)
    where OpenXmlElementType: DXW.TableGridChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetPreviousTableGrid(openXmlElement, value?.PreviousTableGrid);
      return openXmlElement;
    }
    return default;
  }
}
