namespace DocumentModel.Wordprocessing;

/// <summary>
/// Hide Style From Main User Interface.
/// </summary>
public interface ISemiHidden // : DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType
{
  /// <summary>
  /// val
  /// </summary>
  public OnOffOnly? Val { get ; set; }
  
}
