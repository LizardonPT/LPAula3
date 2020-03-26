using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            Perks[] perks;
            string aux;
            int numNPCs;

            // Pedir ao user o nº de NPC
            Console.Write("Insira nº da NPCs: ");
            aux = Console.ReadLine();
            numNPCs = Convert.ToInt32(aux);
            perks = new Perks[numNPCs];

            // Para cada NPC, pedir as suas caracteristicas
            for (int i = 0; i < numNPCs; i++)
            {
                Console.Write($"NPC {i} tem Stealth (s/n)? ");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= NPCsPerks.Stealth;
                }
                Console.Write($"NPC {i} tem Stealth (s/n)? ");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= NPCsPerks.Combat;
                }
                Console.Write($"NPC {i} tem Stealth (s/n)? ");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= NPCsPerks.Lockpick;
                }
                Console.Write($"NPC {i} tem Stealth (s/n)? ");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= NPCsPerks.Luck;
                }
            }

            // Mostrar no ecrã as caracteristicas
            Console.WriteLine();

            for (int i = 0; i < numNPCs; i++)
            {
                Perks p = Perks.Combat | Perks.Luck;
                Console.WriteLine($"Perks do NPC {i}: {perks[i]}");

                if ((Perks[i] & p) == p)
                {
                    Console.WriteLine("\tYou shall win all fights");
                }
            }
        }
    }
}
