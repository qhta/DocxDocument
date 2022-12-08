namespace DocumentModel.Wordprocessing;

/// <summary>
/// Complex Field Character.
/// </summary>
public class FieldCharImpl: ModelElementImpl, FieldChar
{
  public DocumentFormat.OpenXml.Wordprocessing.FieldChar? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FieldChar?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  /// Field Should Not Be Recalculated
  /// </summary>
  public Boolean? FieldLock
  {
    get;
    set;
  }
  
  /// <summary>
  /// Field Result Invalidated
  /// </summary>
  public Boolean? Dirty
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom Field Data.
  /// </summary>
  public String? FieldData
  {
    get;
    set;
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
