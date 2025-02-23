#nullable disable

using System;
using System.Collections.Generic;

namespace Pathoschild.Stardew.Automate.Framework.Commands.Summary
{
    /// <summary>Metadata about containers of the same type within a machine group.</summary>
    internal class GroupContainerStats
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The container name.</summary>
        public string Name { get; }

        /// <summary>The number of containers in the group.</summary>
        public int Count { get; }

        /// <summary>The number of slots filled with an item slot.</summary>
        public int FilledSlots { get; }

        /// <summary>The number of empty slots.</summary>
        public int TotalSlots { get; }

        /// <summary>Whether the container is a Junimo chest.</summary>
        public bool IsJunimoChest { get; }


        /*********
        ** Public methods
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="name">The container name.</param>
        /// <param name="containers">The containers in the group.</param>
        public GroupContainerStats(string name, IEnumerable<IContainer> containers)
        {
            this.Name = name;

            foreach (IContainer container in containers)
            {
                // only track Junimo chests once
                if (container.IsJunimoChest)
                {
                    if (this.IsJunimoChest)
                        continue;
                    this.IsJunimoChest = true;
                }

                // track stats
                int filled = container.GetFilled();
                this.Count++;
                this.FilledSlots += filled;
                this.TotalSlots += Math.Max(filled, container.GetCapacity());
            }
        }
    }
}
