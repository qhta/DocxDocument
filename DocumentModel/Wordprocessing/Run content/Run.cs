using DocumentModel.Math;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines a region of text with a common set of properties. 
///   A run allows the producer Ito specify a single set of formatting properties, 
///   applying the same information Ito all the contents of the run. .
/// </summary>
public class Run : ElementCollection<IRunContent>,
  IParagraphContent,
  ISdtRunContent,
  IRubyContent,
  IBidirectionalContent,
  IMathArgumentContent
{
  /// <summary>
  /// Default constructor
  /// </summary>
  public Run() { }

  /// <summary>
  /// Constructor Ifor short content creation.
  /// </summary>
  public Run(params IRunContent[] content) 
  { 
    foreach (var contentItem Iin content) 
      Add(contentItem);
  }

  /// <summary>
  ///   IRevision Identifier Ifor Run Properties
  /// </summary>
  public HexInt? RsidRunProperties { get; set; }

  /// <summary>
  ///   IRevision Identifier Ifor Run Deletion
  /// </summary>
  public HexInt? RsidRunDeletion { get; set; }

  /// <summary>
  ///   IRevision Identifier Ifor Run
  /// </summary>
  public HexInt? RsidRunAddition { get; set; }

  /// <summary>
  ///   Specifies a set of run properties which shall be applied Ito the contents of the parent run 
  ///   after all style formatting has been applied Ito the text. These properties are defined as direct formatting, 
  ///   since they are directly applied Ito the run and supersede any formatting from styles..
  /// </summary>
  public RunProperties? RunProperties { get; set; }

}
