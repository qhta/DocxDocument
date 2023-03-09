namespace DocumentModel.Wordprocessing;

/// <summary>
///   Phonetic Guide Text Run.
/// </summary>
public class Run: ElementCollection<IRunElement>, ICommonRunElement
{
  /// <summary>
  ///   Revision Identifier for Run Properties
  /// </summary>
  [XmlAttribute] public HexInt? RsidRunProperties { get; set; }

  /// <summary>
  ///   Revision Identifier for Run Deletion
  /// </summary>
  [XmlAttribute] public HexInt? RsidRunDeletion { get; set; }

  /// <summary>
  ///   Revision Identifier for Run
  /// </summary>
  [XmlAttribute] public HexInt? RsidRunAddition { get; set; }

  /// <summary>
  ///   Run Properties.
  /// </summary>
  [XmlAnyElement] public RunProperties? RunProperties { get; set; }

}