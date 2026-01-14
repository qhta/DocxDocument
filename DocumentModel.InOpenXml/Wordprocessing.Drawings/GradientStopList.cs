namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents a collection of gradient stops for a gradient fill in a Wordprocessing drawing element.
/// This interface provides access to and management of <see cref="GradientStop"/> objects, enabling the definition of complex color transitions and gradient effects.
/// </summary>
public interface GradientStopList : ElementCollection<GradientStop>
{
}