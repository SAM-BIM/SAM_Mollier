"""Repository-specific classification decisions for SAM_Mollier (the only non-shared tool file).

OVERRIDES     : component display name -> (object glyph, op, extra)   extra: None | "plural" | "library" | note
PARAM_OBJECTS : param type key (Goo<X>Param class or typeof(X) name) -> glyph | (glyph, container, plural)
OBJECTS/VERBS : extra noun/verb rules tried before the shared ones (same shapes as SAM's OBJECTS/VERBS)
"""
OVERRIDES = {
    # air handling unit
    "SAMMollier.CreateAHU": ("ahu", "create", "assembles an AHU from process chains"),
    "SAMMollier.CalculateAHU": ("ahu", "calculate", None),
    # loads
    "SAMMollier.CalculateLoads": ("heat", "calculate", "space loads incl. infiltration"),
    "SAMMollier.LoadByProcess": ("mollierProcess", "calculate", "sensible/latent/total load of a process"),
    # air-state utilities: draw the quantity computed
    "SAMMollier.Psychrometrics": ("mollierChart", "calculate", "all psychrometric properties"),
    "SAMMollier.SpecificHeat": ("mollierPoint", "calculate", "property of an air state"),
    "SAMMollier.DiagramTemperature": ("thermometer", "convert", "dry-bulb -> diagram temperature"),
    "SAMMollier.DryBulbTemperature": ("thermometer", "calculate", None),
    "SAMMollier.DryBulbTemperatureByBypassFactor": ("thermometer", "calculate", None),
    "SAMMollier.Epsilon": ("processRoom", "calculate", "room-process slope"),
    "SAMMollier.EpsilonBySensibleAndLatentLoad": ("processRoom", "calculate", None),
    "SAMMollier.EpsilonBySteamTemperature": ("processRoom", "calculate", None),
    "SAMMollier.EpsilonByWaterTemperature": ("processRoom", "calculate", None),
    "SAMMollier.ApparatusDewPoint": ("processCooling", "calculate", "ADP of a cooling coil"),
    # mass flows
    "SAMMollier.DryAirMassFlow": ("airflow", "calculate", None),
    "SAMMollier.DryAirMassFlowByMollierPoint": ("airflow", "calculate", None),
    "SAMMollier.MassFlowRate": ("airflow", "convert", "volumetric -> mass flow"),
    "SAMMollier.MoistureGainsMassFlow": ("processHumidification", "calculate", "moisture gains mass flow"),
    # points and groups
    "SAMWeather.MollierPoints": ("mollierPoint", "get", "from weather data"),
    "SAMMollier.MollierPointsByPercentage": ("mollierPoint", "filter", None),
    "SAMMollier.HourlyValues": ("weatherData", "get", "plural"),
    "SAMMollier.CreateMollierGroup": ("group", "create", None),
}
PARAM_OBJECTS = {}
OBJECTS = []
VERBS = []
