
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape?view=office-pia"/>
public partial class Shape
{
  /// <summary>
  /// Invokes `Apply`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.apply?view=office-pia"/>
  public void Apply() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Duplicate`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.duplicate?view=office-pia"/>
  public Shape Duplicate() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Flip`.
  /// </summary>
  /// <param name="FlipCmd">The `FlipCmd` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.flip?view=office-pia"/>
  public void Flip(FlipCmd FlipCmd) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `IncrementLeft`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.incrementleft?view=office-pia"/>
  public void IncrementLeft(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `IncrementRotation`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.incrementrotation?view=office-pia"/>
  public void IncrementRotation(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `IncrementTop`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.incrementtop?view=office-pia"/>
  public void IncrementTop(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `PickUp`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.pickup?view=office-pia"/>
  public void PickUp() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `RerouteConnections`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.rerouteconnections?view=office-pia"/>
  public void RerouteConnections() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ScaleHeight`.
  /// </summary>
  /// <param name="Factor">The `Factor` parameter.</param>
  /// <param name="RelativeToOriginalSize">The `RelativeToOriginalSize` parameter.</param>
  /// <param name="fScale">The `fScale` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.scaleheight?view=office-pia"/>
  public void ScaleHeight
    (float Factor, TriState RelativeToOriginalSize, ScaleFrom fScale)
  { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ScaleWidth`.
  /// </summary>
  /// <param name="Factor">The `Factor` parameter.</param>
  /// <param name="RelativeToOriginalSize">The `RelativeToOriginalSize` parameter.</param>
  /// <param name="fScale">The `fScale` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.scalewidth?view=office-pia"/>
  public void ScaleWidth
    (float Factor, TriState RelativeToOriginalSize, ScaleFrom fScale)
  { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <param name="Replace">The `Replace` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.select?view=office-pia"/>
  public void Select(object Replace) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetShapesDefaultProperties`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.setshapesdefaultproperties?view=office-pia"/>
  public void SetShapesDefaultProperties() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Ungroup`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.ungroup?view=office-pia"/>
  public ShapeRange Ungroup() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ZOrder`.
  /// </summary>
  /// <param name="ZOrderCmd">The `ZOrderCmd` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.zorder?view=office-pia"/>
  public void ZOrder(ZOrderCmd ZOrderCmd) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CanvasCropLeft`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.canvascropleft?view=office-pia"/>
  public void CanvasCropLeft(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CanvasCropTop`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.canvascroptop?view=office-pia"/>
  public void CanvasCropTop(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CanvasCropRight`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.canvascropright?view=office-pia"/>
  public void CanvasCropRight(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CanvasCropBottom`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.canvascropbottom?view=office-pia"/>
  public void CanvasCropBottom(float Increment) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Cut`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.cut?view=office-pia"/>
  public void Cut() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.copy?view=office-pia"/>
  public void Copy() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ConvertTextToSmartArt`.
  /// </summary>
  /// <param name="Layout">The `Layout` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shape.converttexttosmartart?view=office-pia"/>
  public void ConvertTextToSmartArt(SmartArtLayout Layout) { throw new NotImplementedException(); }
}

