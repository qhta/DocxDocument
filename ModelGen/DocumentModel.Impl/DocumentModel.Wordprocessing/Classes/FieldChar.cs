namespace DocumentModel.Wordprocessing;

/// <summary>
/// Complex Field Character.
/// </summary>
public class FieldCharImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.FieldChar>, FieldChar
{
  /// <summary>
  /// Field Character Type
  /// </summary>
  public FieldCharKind? FieldCharType
  {
    get => (FieldCharKind?)OpenXmlElement?.FieldCharType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FieldCharType = (DocumentFormat.OpenXml.Wordprocessing.FieldCharValues?)value;
    }
  }
  
  /// <summary>
  /// Form Field Properties.
  /// </summary>
  public FormFieldData? FormFieldData
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Numbering Field Properties.
  /// </summary>
  public NumberingChange? NumberingChange
  {
    get;
    set;
  }
  
}
