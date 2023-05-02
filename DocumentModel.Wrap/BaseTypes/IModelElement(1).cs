using DocumentFormat.OpenXml.Office2019.Excel.RichData2;

namespace DocumentModel;

/// <summary>
///   Interface for model elements which wraps OpenXml elements.
/// </summary>
public interface IModelElement<ElementType>: IModelElement
  where ElementType: DX.OpenXmlElement
{
  /// <summary>
  /// Wrapped OpenXml element.
  /// </summary>
  public ElementType Element { get; }
}