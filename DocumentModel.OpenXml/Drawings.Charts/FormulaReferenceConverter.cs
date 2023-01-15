using DocumentFormat.OpenXml.Office2013.Drawing.Chart;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the FormulaReference Class.
/// </summary>
public static class FormulaReferenceConverter
{
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  public static String? GetSequenceOfReferences(FormulaReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SequenceOfReferences>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetSequenceOfReferences(FormulaReference? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SequenceOfReferences>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SequenceOfReferences { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.FormulaReference? CreateModelElement(FormulaReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FormulaReference();
      value.SequenceOfReferences = GetSequenceOfReferences(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FormulaReference? value)
    where OpenXmlElementType : FormulaReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSequenceOfReferences(openXmlElement, value?.SequenceOfReferences);
      return openXmlElement;
    }
    return default;
  }
}