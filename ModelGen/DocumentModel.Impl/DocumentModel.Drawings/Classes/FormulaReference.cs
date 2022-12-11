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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
