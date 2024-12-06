using System.Data;

namespace allerts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("costruttore", "allerta");
            //a questo punto non esistono ancora i componenti della form
            //inizializzazione variabili
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("load");
        }

        private void messaggio(object obj)
        {
            Thread[] mes = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                mes[i] = new Thread(messaggio1);
                mes[i].Start(obj);
            }
            /*//primo metodo
            Class1 arg = (Class1)obj;
            MessageBox.Show(arg.Numero.ToString(), arg.Caption);

            //secondo metodo
            Class1 argomento = obj as Class1;
            MessageBox.Show(argomento.Numero.ToString(), argomento.Caption);

            //terzo metodo
            MessageBox.Show(((Class1)arg).Numero.ToString(), ((Class1)arg).Caption);*/
        }

        private void messaggio1(object obj)
        {
            Class1 arg = (Class1)obj;
            MessageBox.Show(arg.Numero.ToString(), arg.Caption);
        }
        
        private void Form1_Shown(object sender, EventArgs e)
        {
            //avvio del del thread che esegue la messagebox
            //MessageBox.Show("shown", "debug");
            
            Class1 uno = new Class1(1, "ciao");
            Class1 due = new Class1(2, "hello");

            Thread thread1 = new Thread(messaggio);
            Thread thread2 = new Thread(messaggio);
            thread1.Start(uno);
            thread2.Start(due);
        }
    }
}
