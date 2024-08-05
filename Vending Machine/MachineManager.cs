using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class MachineManager
    {
        private List<AbstractMachine> _machines;   //Методы: 1.Добавление нового аппарата; 2. Удаление аппаратаБ; 3. Поиск аппарата по ид;
                                                   //4. Добавление рецепта; 5. Пополнение проуктов 6. Вывод всех рецептов отдельно по ид кофемашины
        public MachineManager()
        {
            _machines = new List<AbstractMachine>();
        }

        public void AddMachine(AbstractMachine machine)
        {
            _machines.Add(machine);
        }

        public void RemoveMachine(AbstractMachine machine)
        {
            _machines.Remove(machine);
        }

        public AbstractMachine GetMachineById(int id)
        {
            foreach (var machine in _machines)
            {
                if (machine.Id == id)
                {
                    return machine;
                } 
            }
            Console.WriteLine($"Machine with ID {id} not found.");
            return null;
        }

        public void GetAllProducts ()
        {
            foreach (var machine in _machines)
            {
                Console.WriteLine($"Machine ID: {machine.Id}");
                machine.DisplayProducts();
                Console.WriteLine();
            }
        }

        public void GetAllRecipes()
        {
            foreach (var machine in _machines)
            {
                Console.WriteLine($"Machine ID: {machine.Id}");
                machine.DisplayRecipes();
                Console.WriteLine();
            }
        }



    }
}
