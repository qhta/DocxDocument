namespace DocumentModel.Office2021.Word.ExtensionList;

/// <summary>
/// Defines the Extension Class.
/// </summary>
public class Extension: IExtension
{
  /// <summary>
  /// uri, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
