namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NumRefExtension Class.
/// </summary>
public class NumRefExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FullReference? FullReference { get; set; }

  public LevelReference? LevelReference { get; set; }

  public FormulaReference? FormulaReference { get; set; }
}