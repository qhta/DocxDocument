using DocumentModel.Math;

namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines a region of text with a common set of properties. 
///   A run allows the producer to specify a single set of formatting properties, 
///   applying the same information to all the contents of the run. .
/// </summary>
[OpenXmlType(typeof(DXW.Run))]
[XmlRoot("Run", Namespace = "DocumentModel.Wordprocessing")]
public partial class Run : ModelElement<DXW.Run>, //RunContentCollection,
 IParagraphContent, ISdtRunContent, IRubyContent, IBidirectionalContent, IMathArgumentContent
{
  /// <summary>
  /// Initializes a new instance of the Run class.
  /// </summary>
  public Run() : base() { }

  /// <summary>
  /// Initializes a new instance of the Run class with the specified parent object.
  /// </summary>
  /// <param name="parent">The parent object that will contain this Run instance. This parameter establishes the hierarchical relationship
  /// within the object model and cannot be null.</param>
  public Run(object parent) : base(parent) { }

  /// <summary>
  ///   Revision Identifier for Run Properties
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RsidRunProperties))]
  public HexInt? RsidRunProperties { get => _RsidRunProperties; set => UpdateField(ref _RsidRunProperties, value, nameof(RsidRunProperties)); }
  private HexInt? _RsidRunProperties;

  /// <summary>
  ///   Revision Identifier for Run Deletion
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RsidRunDeletion))]
  public HexInt? RsidRunDeletion { get => _RsidRunDeletion; set => UpdateField(ref _RsidRunDeletion, value, nameof(RsidRunDeletion)); }
  private HexInt? _RsidRunDeletion;

  /// <summary>
  ///   Revision Identifier for Run
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RsidRunAddition))]
  public HexInt? RsidRunAddition { get => _RsidRunAddition; set => UpdateField(ref _RsidRunAddition, value, nameof(RsidRunAddition)); }
  private HexInt? _RsidRunAddition;

  /// <summary>
  ///   Specifies a set of run properties which shall be applied to the contents of the parent run 
  ///   after all style formatting has been applied to the text. These properties are defined as direct formatting, 
  ///   since they are directly applied to the run and supersede any formatting from styles..
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RunProperties))]
  public RunProperties? RunProperties { get => _RunProperties; set => UpdateField(ref _RunProperties, value, nameof(RunProperties)); }
  private RunProperties? _RunProperties;
}