namespace Program 
{
    class BattleManager 
    {
        public void startBattle(Character player) 
        {
            bool running = true;
            Ogre ogre = new Ogre();
            OgreMage ogreMage = new OgreMage();
            
            do 
            {     
            Console.WriteLine("Battle started\n");
            Console.WriteLine("*****************************");
                  
            Console.WriteLine("Wild Ogre appears!");
            bool isDefeated = ogre.calculateDamage(player.strength);


            } while (running);
            running = true; 
            do 
            {
             Console.WriteLine("Battle started\n");
             Console.WriteLine("*****************************");   

             Console.WriteLine("Wild Ogre Mage appears!");
             bool isDefeated = ogreMage.calculateDamage(player.strength);

             running = !isDefeated;
            } while (running);

        }
    }
}