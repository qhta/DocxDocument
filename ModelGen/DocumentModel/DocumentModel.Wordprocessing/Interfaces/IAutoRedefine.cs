namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatically Merge User Formatting Into Style Definition.
/// </summary>
public interface IAutoRedefine // : DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType
{
  /// <summary>
  /// val
  /// </summary>
  public OnOffOnlyValues? Val { get ; set; }
  
}
