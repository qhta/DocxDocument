namespace DocumentModel.Vml;
/// <summary>
///   Shape Fill Extended Properties.
/// </summary>
[OpenXmlType(typeof(DXVO.FillExtendedProperties))]
public partial class FillExtendedProperties : ModelElement<DXVO.FillExtendedProperties>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.FillExtendedProperties.Extension))]
 [OpenXmlElement(typeof(DXVO.FillExtendedProperties))]
 public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

 private ExtensionHandlingBehaviorKind? _Extension;
 /// <summary>
 ///   Fill Type
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.FillExtendedProperties.Type))]
 [OpenXmlElement(typeof(DXVO.FillExtendedProperties))]
 public FillTypeKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private FillTypeKind? _Type;
}