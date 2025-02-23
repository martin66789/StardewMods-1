#nullable disable

using Microsoft.Xna.Framework;
using StardewValley;
using SObject = StardewValley.Object;

namespace Pathoschild.Stardew.Automate.Framework.Machines.Objects
{
    /// <summary>A soda machine that accepts input and provides output.</summary>
    /// <remarks>Derived from <see cref="SObject.DayUpdate"/> (search for 'case 117').</remarks>
    internal class SodaMachine : GenericObjectMachine<SObject>
    {
        /*********
        ** Public methods
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="machine">The underlying machine.</param>
        /// <param name="location">The location containing the machine.</param>
        /// <param name="tile">The tile covered by the machine.</param>
        public SodaMachine(SObject machine, GameLocation location, Vector2 tile)
            : base(machine, location, tile, machineTypeId: "SodaMachine") { }

        /// <summary>Get the machine's processing state.</summary>
        public override MachineState GetState()
        {
            return this.Machine.heldObject.Value != null
                ? MachineState.Done
                : MachineState.Processing;
        }

        /// <summary>Provide input to the machine.</summary>
        /// <param name="input">The available items.</param>
        /// <returns>Returns whether the machine started processing an item.</returns>
        public override bool SetInput(IStorage input)
        {
            return false; // no input
        }
    }
}
