namespace DocumentModel.Wordprocessing;

/// <summary>
/// External Data Source to Merge Field Mapping.
/// </summary>
public class FieldMapDataImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.FieldMapData>, FieldMapData
{
  /// <summary>
  /// Merge Field Mapping.
  /// </summary>
  public MailMergeOdsoFieldKind? MailMergeFieldType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType>();
        return (MailMergeOdsoFieldKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType{ Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
