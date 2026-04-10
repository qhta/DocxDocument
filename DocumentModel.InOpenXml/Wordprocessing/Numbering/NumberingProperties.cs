namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the numbering properties for a paragraph or list item in a WordprocessingML document.
/// This class provides properties for referencing numbering levels, numbering definition instances, previous numbering changes, and inserted numbering properties, enabling advanced list and outline numbering management and revision tracking.
/// </summary>
[OpenXmlType(typeof(DXW.NumberingProperties))]
[XmlRoot("NumberingProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class NumberingProperties : ModelElement<DXW.NumberingProperties>
{
 /// <summary>
 /// Reference to the numbering level applied to the paragraph or list item.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.NumberingProperties.NumberingLevelReference))]
 public NumLevel? NumberingLevelReference { get => _NumberingLevelReference; set => UpdateField(ref _NumberingLevelReference, value, nameof(NumberingLevelReference)); }

 private NumLevel? _NumberingLevelReference;
 /// <summary>
 /// Reference to the numbering definition instance used for the paragraph or list item.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.NumberingProperties.NumberingId))]
 public Int32? NumberingId { get => _NumberingId; set => UpdateField(ref _NumberingId, value, nameof(NumberingId)); }

 private Int32? _NumberingId;
 /// <summary>
 /// Previous paragraph numbering properties, enabling tracking and management of numbering revisions.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.NumberingProperties.NumberingChange))]
 public NumberingChange? NumberingChange { get => _NumberingChange; set => UpdateField(ref _NumberingChange, value, nameof(NumberingChange)); }

 private NumberingChange? _NumberingChange;
 /// <summary>
 /// Inserted numbering properties, used to track newly added numbering information as part of revisions.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.NumberingProperties.Inserted))]
 public Inserted? Inserted { get => _Inserted; set => UpdateField(ref _Inserted, value, nameof(Inserted)); }

 private Inserted? _Inserted;
}