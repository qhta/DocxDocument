using System.Runtime.Serialization;
namespace DocumentModel.Drawings;

/// <summary>
/// Abstract Fill interface.
/// </summary>
public interface Fill: ITypedModelElement, ICollectionItem, IDrawingProperty
{
}