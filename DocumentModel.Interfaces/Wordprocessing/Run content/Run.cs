using DocumentModel.Math;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines a region of text with a common set of properties. 
///   A run allows the producer to specify a single set of formatting properties, 
///   applying the same information to all the contents of the run. .
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
  /// Constructor for short content creation.
  /// </summary>
  public Run(params IRunContent[] content) 
  { 
    foreach (var contentItem in content) 
      Add(contentItem);
  }
  /// <summary>
  ///   Revision Identifier for Run Properties
  /// </summary>
  public IHexInt? RsidRunProperties { get; set; }
  /// <summary>
  ///   Revision Identifier for Run Deletion
  /// </summary>
  public IHexInt? RsidRunDeletion { get; set; }
  /// <summary>
  ///   Revision Identifier for Run
  /// </summary>
  public IHexInt? RsidRunAddition { get; set; }
  /// <summary>
  ///   Specifies a set of run properties which shall be applied to the contents of the parent run 
  ///   after all style formatting has been applied to the text. These properties are defined as direct formatting, 
  ///   since they are directly applied to the run and supersede any formatting from styles..
  /// </summary>
  public RunProperties? RunProperties { get; set; }
}