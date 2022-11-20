namespace DocumentModel.Wordprocessing;

/// <summary>
/// Complex Field Character.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFieldData))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFormFieldData))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingChange))]
public class FieldChar: IFieldChar
{
  /// <summary>
  /// Field Character Type
  /// </summary>
  public FieldCharValues? FieldCharType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Field Should Not Be Recalculated
  /// </summary>
  public bool? FieldLock
  {
    get;
    set;
  }
  
  /// <summary>
  /// Field Result Invalidated
  /// </summary>
  public bool? Dirty
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom Field Data.
  /// </summary>
  public IFieldData? FieldData
  {
    get;
    set;
  }
  
  /// <summary>
  /// Form Field Properties.
  /// </summary>
  public IFormFieldData? FormFieldData
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Numbering Field Properties.
  /// </summary>
  public INumberingChange? NumberingChange
  {
    get;
    set;
  }
  
}
