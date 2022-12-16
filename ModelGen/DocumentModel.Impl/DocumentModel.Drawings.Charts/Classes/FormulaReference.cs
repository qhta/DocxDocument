namespace DocumentModel.Drawings.Charts;

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
  
  public FormulaReferenceImpl(): base() {}
  
  public FormulaReferenceImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public String? SequenceOfReferences
  {
    get => (System.String?)OpenXmlElement?.SequenceOfReferences?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SequenceOfReferences != null)
        {
          if (value is not null)
            OpenXmlElement.SequenceOfReferences.Text = value;
          else
            OpenXmlElement.SequenceOfReferences = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SequenceOfReferences = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences{ Text = value };
        }
      }
    }
  }
  
}
