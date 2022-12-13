namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the DataLabelFieldTableEntry Class.
/// </summary>
public class DataLabelFieldTableEntryImpl: ModelElementImpl, DataLabelFieldTableEntry
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataLabelFieldTableEntryImpl(): base() {}
  
  public DataLabelFieldTableEntryImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// TextFieldGuid.
  /// </summary>
  public String? TextFieldGuid
  {
    get => (System.String?)OpenXmlElement?.TextFieldGuid?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TextFieldGuid != null)
        {
          if (value is not null)
            OpenXmlElement.TextFieldGuid.Text = value;
          else
            OpenXmlElement.TextFieldGuid = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TextFieldGuid = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.TextFieldGuid{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula
  {
    get => (System.String?)OpenXmlElement?.Formula?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Formula != null)
        {
          if (value is not null)
            OpenXmlElement.Formula.Text = value;
          else
            OpenXmlElement.Formula = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Formula = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// DataLabelFieldTableCache.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataLabelFieldTableCache? DataLabelFieldTableCache
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
