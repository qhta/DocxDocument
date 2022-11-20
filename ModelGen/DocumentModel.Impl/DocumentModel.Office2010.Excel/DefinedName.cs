namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DefinedName Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IArgumentDescriptions))]
public class DefinedName: IDefinedName
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// ArgumentDescriptions.
  /// </summary>
  public IArgumentDescriptions? ArgumentDescriptions
  {
    get;
    set;
  }
  
}
