namespace Content.Shared.Backmen.Abilities.Psionics;

[RegisterComponent]
public sealed partial class PsionicInsulationComponent : Component
{
    public bool Passthrough = false;

    public List<String> SuppressedFactions = new();
}
