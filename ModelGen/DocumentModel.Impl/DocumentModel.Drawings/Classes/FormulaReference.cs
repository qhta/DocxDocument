namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FormulaReference Class.
/// </summary>
public class FormulaReferenceImpl: ModelElementImpl, FormulaReference
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public String? SequenceOfReferences
  {
    get;
    set;
  }
  
}
