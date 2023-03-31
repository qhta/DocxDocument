namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Phonetic Guide Text Run.
/// </summary>
public class Run: ElementCollection<IRunElement>, ICommonRunElement
{
  /// <summary>
  ///   Revision Identifier for Run Properties
  /// </summary>
  public HexInt? RsidRunProperties { get; set; }

  /// <summary>
  ///   Revision Identifier for Run Deletion
  /// </summary>
  public HexInt? RsidRunDeletion { get; set; }

  /// <summary>
  ///   Revision Identifier for Run
  /// </summary>
  public HexInt? RsidRunAddition { get; set; }

  /// <summary>
  ///   Run Properties.
  /// </summary>
  public RunProperties? RunProperties { get; set; }

}