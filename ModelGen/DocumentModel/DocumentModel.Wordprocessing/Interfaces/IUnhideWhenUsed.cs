namespace DocumentModel.Wordprocessing;

/// <summary>
/// Remove Semi-Hidden Property When Style Is Used.
/// </summary>
public interface IUnhideWhenUsed // : DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType
{
  /// <summary>
  /// val
  /// </summary>
  public OnOffOnlyValues? Val { get ; set; }
  
}
