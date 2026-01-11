namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of frames and framesets in a WordprocessingML document.
/// This interface provides access to and management of <see cref="FramesetItem"/> objects, enabling advanced configuration and organization of nested frames and framesets within document layouts.
/// </summary>
public interface FramesetItems : ElementCollection<FramesetItem>
{

}