using DocumentFormat.OpenXml.Wordprocessing;
using PreviousTableGrid = DocumentModel.Wordprocessing.PreviousTableGrid;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Revision Information for Table Grid Column Definitions.
/// </summary>
public static class TableGridChangeConverter
{
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public static String? GetId(TableGridChange? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(TableGridChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Previous Table Grid.
  /// </summary>
  public static PreviousTableGrid? GetPreviousTableGrid(TableGridChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid>();
    if (itemElement != null)
      return PreviousTableGridConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPreviousTableGrid(TableGridChange? openXmlElement, PreviousTableGrid? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousTableGridConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TableGridChange? CreateModelElement(TableGridChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableGridChange();
      value.Id = GetId(openXmlElement);
      value.PreviousTableGrid = GetPreviousTableGrid(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableGridChange? value)
    where OpenXmlElementType : TableGridChange, new()
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