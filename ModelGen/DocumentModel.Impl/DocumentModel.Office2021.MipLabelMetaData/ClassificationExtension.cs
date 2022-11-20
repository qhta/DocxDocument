namespace DocumentModel.Office2021.MipLabelMetaData;

/// <summary>
/// Defines the ClassificationExtension Class.
/// </summary>
public class ClassificationExtension: IClassificationExtension
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
