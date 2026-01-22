namespace DocumentModel.Wordprocessing;
/// <summary>
///   Numbering Definitions.
/// </summary>
public partial class Numbering : ModelElement<DXW.Numbering>
{
    /// <summary>
    /// Specifies to a consumer the progress in the last attempt made by the application 
    /// to remove unused abstract numbering definitions from a given document. 
    /// </summary>
    public HexInt? NumberingIdMacAtCleanup { get => _NumberingIdMacAtCleanup; set => UpdateField(ref _NumberingIdMacAtCleanup, value, nameof(NumberingIdMacAtCleanup)); }

    private HexInt? _NumberingIdMacAtCleanup;
    /// <summary>
    /// Collection of abstract numbering definitions
    /// </summary>
    public AbstractNums? AbstractNums { get; set; }
    /// <summary>
    /// Collection of numbering instances definitions
    /// </summary>
    public NumberingInstances? NumberingInstances { get; set; }
    /// <summary>
    /// Collection of numbering picture bullets
    /// </summary>
    public NumberingPictureBullets? NumberingPictureBullets { get; set; }
}