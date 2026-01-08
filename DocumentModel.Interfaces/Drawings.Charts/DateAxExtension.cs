namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DateAxExtension Class.
/// </summary>
public interface DateAxExtension: Extension
{
  public NumberingFormat3? NumberingFormat { get; set; }
}