namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberingProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingId))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingLevelReference))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IInserted))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingChange))]
public class NumberingProperties: INumberingProperties
{
  /// <summary>
  /// Numbering Level Reference.
  /// </summary>
  public INumberingLevelReference? NumberingLevelReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Numbering Definition Instance Reference.
  /// </summary>
  public INumberingId? NumberingId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Paragraph Numbering Properties.
  /// </summary>
  public INumberingChange? NumberingChange
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inserted Numbering Properties.
  /// </summary>
  public IInserted? Inserted
  {
    get;
    set;
  }
  
}
