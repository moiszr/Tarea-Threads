using Tarea_Threads;

Threads thread = new Threads();
Thread t1 = new Thread(new ThreadStart(thread.Cocinar_Arroz));
Thread t2 = new Thread(new ThreadStart(thread.Cocinar_Habichuela));

t1.Start(); t2.Start();
thread.Cocinar_Pollo();
