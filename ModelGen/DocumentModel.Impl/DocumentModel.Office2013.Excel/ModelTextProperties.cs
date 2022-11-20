namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the ModelTextProperties Class.
/// </summary>
public class ModelTextProperties: IModelTextProperties
{
  /// <summary>
  /// headers, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Headers
  {
    get;
    set;
  }
  
}
