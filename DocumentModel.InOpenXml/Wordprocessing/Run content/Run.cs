using DocumentModel.Math;

namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines a region of text with a common set of properties. 
///   A run allows the producer to specify a single set of formatting properties, 
///   applying the same information to all the contents of the run. .
/// </summary>
[OpenXmlType(typeof(DXW.Run))]
[XmlRoot("Run", Namespace = "DocumentModel.Wordprocessing")]
[DirectAccess(true)]
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
  public Run(ModelElement parent) : base(parent) { }
  
  /// <summary>
  /// Initializes a new instance of the Run class using the specified OpenXmlCompositeElement as the underlying XML
  /// element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlCompositeElement that provides the XML data for the Run instance. Cannot be null.</param>
  public Run(DX.OpenXmlCompositeElement openXmlElement) : base(openXmlElement) { }

  private DXW.Run _openXmlRun => _openXmlElement as DXW.Run ?? throw new InvalidOperationException("Underlying OpenXml element is not of type DXW.Run.");

  /// <summary>
  ///   Revision Identifier for Run Properties
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RsidRunProperties))]
  public HexInt? RsidRunProperties
  {
    get => OpenXmlModelConverter.ConvertFrom<HexInt?, DX.HexBinaryValue>(_openXmlRun.RsidRunProperties);
    set => _openXmlRun.RsidRunProperties = OpenXmlModelConverter.ConvertTo<HexInt?, DX.HexBinaryValue>(value);
  }


  /// <summary>
  ///   Revision Identifier for Run Deletion
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RsidRunDeletion))]
  public HexInt? RsidRunDeletion
  {
    get => OpenXmlModelConverter.ConvertFrom<HexInt?, DX.HexBinaryValue>(_openXmlRun.RsidRunDeletion);
    set => _openXmlRun.RsidRunDeletion = OpenXmlModelConverter.ConvertTo<HexInt?, DX.HexBinaryValue>(value);
  }

  /// <summary>
  ///   Revision Identifier for Run
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RsidRunAddition))]
  public HexInt? RsidRunAddition
  {
    get => OpenXmlModelConverter.ConvertFrom<HexInt?, DX.HexBinaryValue>(_openXmlRun.RsidRunAddition);
    set => _openXmlRun.RsidRunAddition = OpenXmlModelConverter.ConvertTo<HexInt?, DX.HexBinaryValue>(value);
  }

  /// <summary>
  ///   Specifies a set of run properties which shall be applied to the contents of the parent run 
  ///   after all style formatting has been applied to the text. These properties are defined as direct formatting, 
  ///   since they are directly applied to the run and supersede any formatting from styles..
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RunProperties))]
  public RunProperties? RunProperties
  {
    get => _RunProperties ??= OpenXmlModelConverter.ConvertFrom<RunProperties?, DXW.RunProperties>(_openXmlRun.RunProperties);
    set => UpdateField(ref _RunProperties, value, nameof(RunProperties));
  }
  private RunProperties? _RunProperties;
}