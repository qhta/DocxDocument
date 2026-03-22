namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies that a given numbering level is from an earlier word processing application 
///   which did not support the full richness of the numbering properties supported by WordprocessingML.
/// </summary>
[OpenXmlType(typeof(DXW.LegacyNumbering))]
public class LegacyNumbering : ModelElement<DXW.LegacyNumbering>
{
 /// <summary>
 ///   Use Legacy Numbering Properties
 /// </summary>
 public Boolean Use { get => _Use; set => UpdateField(ref _Use, value, nameof(Use)); }
 private Boolean _Use;
 /// <summary>
 ///   Legacy Spacing
 /// </summary>
 public Twips? Space { get => _Space; set => UpdateField(ref _Space, value, nameof(Space)); }
 private Twips? _Space;
 /// <summary>
 ///   Legacy Indent
 /// </summary>
 public Twips? Indent { get => _Indent; set => UpdateField(ref _Indent, value, nameof(Indent)); }
 private Twips? _Indent;
}