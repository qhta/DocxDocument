namespace DocumentModel.Vml.Office;

public interface IExtrusion // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public ExtensionHandlingBehavior? Extension { get ; set; }

  public ITrueFalseValue? On { get ; set; }

  public Extrusion? Type { get ; set; }

  public ExtrusionRender? Render { get ; set; }

  public string? ViewpointOrigin { get ; set; }

  public string? Viewpoint { get ; set; }

  public float? SkewAngle { get ; set; }

  public string? SkewAmount { get ; set; }

  public string? ForceDepth { get ; set; }

  public string? BackDepth { get ; set; }

  public string? Orientation { get ; set; }

  public float? OrientationAngle { get ; set; }

  public ITrueFalseValue? LockRotationCenter { get ; set; }

  public ITrueFalseValue? AutoRotationCenter { get ; set; }

  public string? RotationCenter { get ; set; }

  public string? RotationAngle { get ; set; }

  public string? Color { get ; set; }

  public float? Shininess { get ; set; }

  public string? Specularity { get ; set; }

  public string? Diffusity { get ; set; }

  public ITrueFalseValue? Metal { get ; set; }

  public string? Edge { get ; set; }

  public string? Facet { get ; set; }

  public ITrueFalseValue? LightFace { get ; set; }

  public string? Brightness { get ; set; }

  public string? LightPosition { get ; set; }

  public string? LightLevel { get ; set; }

  public ITrueFalseValue? LightHarsh { get ; set; }

  public string? LightPosition2 { get ; set; }

  public string? LightLevel2 { get ; set; }

  public ITrueFalseValue? LightHarsh2 { get ; set; }

}
