
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Shape` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape?view=office-pia` for Office interop details.
/// </remarks>
public partial interface Shape
{
  /// <summary>
  /// Invokes `Apply`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.apply?view=office-pia
  /// </remarks>
  public void Apply();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.delete?view=office-pia
  /// </remarks>
  public void Delete();
  /// <summary>
  /// Invokes `Duplicate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.duplicate?view=office-pia
  /// </remarks>
  public Shape Duplicate();
  /// <summary>
  /// Invokes `Flip`.
  /// </summary>
  /// <param name="FlipCmd">The `FlipCmd` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.flip?view=office-pia
  /// </remarks>
  public void Flip(MsoFlipCmd FlipCmd);
  /// <summary>
  /// Invokes `IncrementLeft`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.incrementleft?view=office-pia
  /// </remarks>
  public void IncrementLeft(float Increment);
  /// <summary>
  /// Invokes `IncrementRotation`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.incrementrotation?view=office-pia
  /// </remarks>
  public void IncrementRotation(float Increment);
  /// <summary>
  /// Invokes `IncrementTop`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.incrementtop?view=office-pia
  /// </remarks>
  public void IncrementTop(float Increment);
  /// <summary>
  /// Invokes `PickUp`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.pickup?view=office-pia
  /// </remarks>
  public void PickUp();
  /// <summary>
  /// Invokes `RerouteConnections`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.rerouteconnections?view=office-pia
  /// </remarks>
  public void RerouteConnections();
  /// <summary>
  /// Invokes `ScaleHeight`.
  /// </summary>
  /// <param name="Factor">The `Factor` parameter.</param>
  /// <param name="RelativeToOriginalSize">The `RelativeToOriginalSize` parameter.</param>
  /// <param name="fScale">The `fScale` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.scaleheight?view=office-pia
  /// </remarks>
  public void ScaleHeight
    (float Factor, MsoTriState RelativeToOriginalSize, MsoScaleFrom fScale);
  /// <summary>
  /// Invokes `ScaleWidth`.
  /// </summary>
  /// <param name="Factor">The `Factor` parameter.</param>
  /// <param name="RelativeToOriginalSize">The `RelativeToOriginalSize` parameter.</param>
  /// <param name="fScale">The `fScale` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.scalewidth?view=office-pia
  /// </remarks>
  public void ScaleWidth
    (float Factor, MsoTriState RelativeToOriginalSize, MsoScaleFrom fScale);
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <param name="Replace">The `Replace` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.select?view=office-pia
  /// </remarks>
  public void Select(object Replace);
  /// <summary>
  /// Invokes `SetShapesDefaultProperties`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.setshapesdefaultproperties?view=office-pia
  /// </remarks>
  public void SetShapesDefaultProperties();
  /// <summary>
  /// Invokes `Ungroup`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.ungroup?view=office-pia
  /// </remarks>
  public ShapeRange Ungroup();
  /// <summary>
  /// Invokes `ZOrder`.
  /// </summary>
  /// <param name="ZOrderCmd">The `ZOrderCmd` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.zorder?view=office-pia
  /// </remarks>
  public void ZOrder(MsoZOrderCmd ZOrderCmd);
  /// <summary>
  /// Invokes `CanvasCropLeft`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.canvascropleft?view=office-pia
  /// </remarks>
  public void CanvasCropLeft(float Increment);
  /// <summary>
  /// Invokes `CanvasCropTop`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.canvascroptop?view=office-pia
  /// </remarks>
  public void CanvasCropTop(float Increment);
  /// <summary>
  /// Invokes `CanvasCropRight`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.canvascropright?view=office-pia
  /// </remarks>
  public void CanvasCropRight(float Increment);
  /// <summary>
  /// Invokes `CanvasCropBottom`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.canvascropbottom?view=office-pia
  /// </remarks>
  public void CanvasCropBottom(float Increment);
  /// <summary>
  /// Invokes `Cut`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.cut?view=office-pia
  /// </remarks>
  public void Cut();
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.copy?view=office-pia
  /// </remarks>
  public void Copy();
  /// <summary>
  /// Invokes `ConvertTextToSmartArt`.
  /// </summary>
  /// <param name="Layout">The `Layout` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.converttexttosmartart?view=office-pia
  /// </remarks>
  public void ConvertTextToSmartArt(SmartArtLayout Layout);
}
