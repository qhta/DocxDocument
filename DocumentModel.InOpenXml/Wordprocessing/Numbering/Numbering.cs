namespace DocumentModel.Wordprocessing;
/// <summary>
///   Numbering Definitions.
/// </summary>
[OpenXmlType(typeof(DXW.Numbering))]
public partial class Numbering : ModelElement<DXW.Numbering>
{
 /// <summary>
 /// Specifies to a consumer the progress in the last attempt made by the application 
 /// to remove unused abstract numbering definitions from a given document. 
 /// </summary>
 [OpenXmlElement(typeof(DXW.Numbering))]
 public HexInt? NumberingIdMacAtCleanup { get => _NumberingIdMacAtCleanup; set => UpdateField(ref _NumberingIdMacAtCleanup, value, nameof(NumberingIdMacAtCleanup)); }

 private HexInt? _NumberingIdMacAtCleanup;
 /// <summary>
 /// Collection of abstract numbering definitions
 /// </summary>
 [OpenXmlElement(typeof(DXW.Numbering))]
 public AbstractNums? AbstractNums { get => _AbstractNums; set => UpdateField(ref _AbstractNums, value, nameof(AbstractNums)); }

 private AbstractNums? _AbstractNums;
 /// <summary>
 /// Collection of numbering instances definitions
 /// </summary>
 [OpenXmlElement(typeof(DXW.Numbering))]
 public NumberingInstances? NumberingInstances { get => _NumberingInstances; set => UpdateField(ref _NumberingInstances, value, nameof(NumberingInstances)); }

 private NumberingInstances? _NumberingInstances;
 /// <summary>
 /// Collection of numbering picture bullets
 /// </summary>
 [OpenXmlElement(typeof(DXW.Numbering))]
 public NumberingPictureBullets? NumberingPictureBullets { get => _NumberingPictureBullets; set => UpdateField(ref _NumberingPictureBullets, value, nameof(NumberingPictureBullets)); }

 private NumberingPictureBullets? _NumberingPictureBullets;
}