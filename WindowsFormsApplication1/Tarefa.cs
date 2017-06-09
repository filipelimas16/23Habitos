using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class load_tarefa : Form

    {
        public string tarefaSelecionada = "";
        private bool alterarTarefa = false;
        public string criarNovo = null;
        int verNovamenteAgenda;
        int sumSegunda, sumTerca, sumQuarta, sumQuinta, sumSexta;
        int resultSegunda, resultTerca, resultQuarta, resultaQuinta, resultSexta;
        int contSegunda, contTerca, contQuarta, contQuinta, contSexta;


        public load_tarefa()
        {
            InitializeComponent();
        }

        public class Tarefa
        {
            public int codigo { get; set; }
            public String tarefa { get; set; }
            public int nivel_prioridade { get; set; }
            public string dayWeek { get; set; }
            public string consequencia { get; set; }
            public string recompensa { get; set; }
            public int nivel_consequencia { get; set; }
            public int nivel_recompensa { get; set; }
            public DateTime data { get; set; }
        }

        public List<Tarefa> list = new List<Tarefa>();
        ArrayList selectedTarefa = new ArrayList();

        private int codigo = -1;//Usado para zerar o codigo e poder inserir um novo usuário.

        private void load_tarefa_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
            cmbo_Dayweek.Text = "Selecione o dia";//Já carrega o cmdbox com a string
        }

        private void CarregarDataGridView()
        {
            //Ordenando na exibição dos dados na list por data
            datagrid_ListTarefas.DataSource = list.OrderBy(x => x.data);
        }

        public int ObterCodigo()
        {
            int retorno = 0;
            if(list.Count == 0)
            {
                retorno = 1;
                return retorno;
            }
            else
            {
                retorno = list.Max(x => x.codigo) + 1;
                return retorno;
            }
        }

        public void LimparControle()
        {
            text_Tarefa.Text = "";
            num_nivelTarefa.Value = 0;
            cmbo_Dayweek.Text = "Selecione o dia";
            text_Consequencia.Text = "";
            text_Recompensa.Text = "";
            num_nivelConsequencia.Value = 0;
            num_nivelRecompensa.Value = 0;
            mask_data.Text = "";
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            bool validar = false;

            if (codigo == -1)
            {
                var tarefa = new Tarefa();

                int nivelConsequencia = Convert.ToInt16(num_nivelConsequencia.Value);
                int nivelRecompensa = Convert.ToInt16(num_nivelRecompensa.Value);
                int nivelTarefa = Convert.ToInt16(num_nivelTarefa.Value);
                if (nivelTarefa > 5)
                {
                    MessageBox.Show("Nível não pode ser maior que cinco");
                }
                else if (nivelTarefa == 0)
                {
                    MessageBox.Show("Nível precisa ser maior que zero");
                }
                else
                {
                    mask_data.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação

                    if(text_Tarefa.Text != "" && num_nivelTarefa.Value > 0 
                        && cmbo_Dayweek.Text != "Selecione o dia"  && text_Consequencia.Text != "" 
                        && text_Recompensa.Text != ""  && num_nivelConsequencia.Value > 0
                        && num_nivelRecompensa.Value > 0 && mask_data.Text != "")
                    {
                        mask_data.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

                        //Adicionando os dados na lista
                        tarefa.codigo = ObterCodigo();
                        tarefa.tarefa = text_Tarefa.Text;
                        tarefa.consequencia = text_Consequencia.Text;
                        tarefa.recompensa = text_Recompensa.Text;
                        tarefa.dayWeek = cmbo_Dayweek.Text;
                        tarefa.nivel_prioridade = nivelTarefa;
                        tarefa.nivel_consequencia = nivelConsequencia;
                        tarefa.nivel_recompensa = nivelRecompensa;
                        tarefa.data = Convert.ToDateTime(mask_data.Text);
                        list.Add(tarefa);
                        CarregarDataGridView();
                        LimparControle();

                        validar = true;
                        MessageBox.Show("Tarefa inserida com sucesso!");
                    }
                }
                if(validar == false)
                {
                    MessageBox.Show("Campos vazios, favor preenche-los. 'Campo data é obrigatório'");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alunos frms = new Alunos();
            frms.ShowDialog();
        }

        private void btn_ListTarefas_Click(object sender, EventArgs e)
        {
            datagrid_ListTarefas.DataSource = null;//limpa o grid;
            datagrid_ListTarefas.DataSource = list;
            datagrid_ListTarefas.Refresh();
        }

        private void datagrid_ListTarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            btn_Alterar.Enabled = true;
            btn_Excluir.Enabled = true;
            btn_Salvar.Visible = false;
            btn_Criarnovo.Visible = true;
            criarNovo = btn_Criarnovo.Text = "Criar novo";
            //Recuperar linha selecionada
            //tarefaSelecionada = datagrid_ListTarefas.Rows[e.RowIndex].Cells[0].Value.ToString();
            int cod = Convert.ToInt32(datagrid_ListTarefas.CurrentRow.Cells[0].Value);
            var tarefa = list.SingleOrDefault(x => x.codigo == cod);

            //Preenche os campos com os valores armazenados na lista
            text_Tarefa.Text = tarefa.tarefa;
            text_Consequencia.Text = tarefa.consequencia;
            text_Recompensa.Text = tarefa.recompensa;
            num_nivelConsequencia.Value = tarefa.nivel_recompensa;
            num_nivelRecompensa.Value = tarefa.nivel_recompensa;
            num_nivelTarefa.Value = tarefa.nivel_prioridade;
            cmbo_Dayweek.Text = tarefa.dayWeek;
            mask_data.Text = Convert.ToString(tarefa.data);

            //Informa que o usuário quer alterar os dados, portanto a variavel será verdadeira
            alterarTarefa = true;
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            bool validar = false;//Criado para saber se os campos foram preenchidos

            int cod = Convert.ToInt32(datagrid_ListTarefas.CurrentRow.Cells[0].Value);
            var tarefa = list.SingleOrDefault(x => x.codigo == cod);

            int nivelConsequencia = Convert.ToInt16(num_nivelConsequencia.Value);
            int nivelRecompensa = Convert.ToInt16(num_nivelRecompensa.Value);
            int nivelPrio = Convert.ToInt16(num_nivelTarefa.Value);
            if (nivelPrio > 5)
            {
                MessageBox.Show("Nível de prioridade não pode ser maior que cinco");
            }
            else if (nivelPrio == 0)
            {
                MessageBox.Show("Nível precisa ser maior que zero");
            }
            else if (alterarTarefa == true)
                {

                     mask_data.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação

                if (text_Tarefa.Text != "" && num_nivelTarefa.Value > 0
                    && cmbo_Dayweek.Text != "Selecione o dia" && text_Consequencia.Text != ""
                    && text_Recompensa.Text != "" && num_nivelConsequencia.Value > 0
                    && num_nivelRecompensa.Value > 0 && mask_data.Text != "")
                {
                    mask_data.TextMaskFormat = MaskFormat.IncludePromptAndLiterals; // retorna a formatação

                    //Alterandos dados da lista
                    tarefa.tarefa = text_Tarefa.Text;
                    tarefa.consequencia = text_Consequencia.Text;
                    tarefa.recompensa = text_Recompensa.Text;
                    tarefa.nivel_consequencia = nivelConsequencia;
                    tarefa.nivel_recompensa = nivelRecompensa;
                    tarefa.nivel_prioridade = nivelPrio;
                    tarefa.dayWeek = cmbo_Dayweek.Text;
                    tarefa.data = Convert.ToDateTime(mask_data.Text);

                    //Zera os dados do grid
                    CarregarDataGridView();
                    LimparControle();
                    //Inicia o codigo para poder aceitar um novo user
                    codigo = -1;
                    validar = true;
                    MessageBox.Show("Tarefa Alterada com sucesso");
                }
           }
            if(validar == false)
            {
                MessageBox.Show("Campos vazios, você precisa preenche-los. 'Campo data é obrigatório");
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(datagrid_ListTarefas.CurrentRow.Cells[0].Value);
            var tarefa = list.SingleOrDefault(x => x.codigo == cod);

            DialogResult resposta = MessageBox.Show("Deseja mesmo excluir essa Tarefa?", "Excluir Tarefa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Caso o usuário tenha clicado em SIM 'YES', o usuário será retirado da lista
            if (resposta == DialogResult.Yes)
            {
                list.Remove(tarefa);
                MessageBox.Show("Tarefa excluida com sucesso!");

                btn_Criarnovo.Visible = false;
                btn_Salvar.Visible = true;
                CarregarDataGridView();
                LimparControle();
                codigo = -1;
            }
        }
        private void num_nivelTarefa_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btn_Criarnovo_Click(object sender, EventArgs e)
        {
            //Usado para zerar dados armazenados no form
            if (criarNovo == "Criar novo")
            {
                CarregarDataGridView();
                LimparControle();
                codigo = -1;
            }
            btn_Criarnovo.Visible = false;
            btn_Salvar.Visible = true;
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void btn_VerAgenda_Click(object sender, EventArgs e)
        {
            //Aqui valida se foi a primeira vez ou se já é a segunda vez ou mais 
            //que esse botão foi clicado. Dessa forma, a lista sempre será zerada e inciada novamente
            //sem ficar duplicando dados
            if (verNovamenteAgenda > 1)
            {
                checkedListBox_Segunda.Items.Clear();
                checkedListBox_Terca.Items.Clear();
                checkedListBox_Quarta.Items.Clear();
                checkedListBox_Quinta.Items.Clear();
                checkedListBox_Sexta.Items.Clear();
            }

            //Verifica se a lista tem algum indice (dados)
            if (list.Count > 0)
            {
                esconderElementos();
                mostrarAgenda();

                foreach (Tarefa t in list)
                {
                    switch (t.dayWeek)
                    {
                        case "segunda":
                            checkedListBox_Segunda.Items.Add(t.tarefa);
                            break;
                        case "terca":
                            checkedListBox_Terca.Items.Add(t.tarefa);
                            break;
                        case "quarta":
                            checkedListBox_Quarta.Items.Add(t.tarefa);
                            break;
                        case "quinta":
                            checkedListBox_Quinta.Items.Add(t.tarefa);
                            break;
                        case "sexta":
                            checkedListBox_Sexta.Items.Add(t.tarefa);
                            break;
                    }

                }
            }
            else
            {
                MessageBox.Show("Nenhuma tarefa inserida na lista");
            }
        }

        private void btn_NovaTarefa_Click(object sender, EventArgs e)
        {
            //Caso o usuário tenha clicado nesse botão ser atriuido 2, que será utilizado
            //No botão de "Ver tarefa" para poder limpar a lista caso o usuário queria ver novamente os dados.
            verNovamenteAgenda = 2;
            esconderAgenda();
            mostrarElementos();
            CarregarDataGridView();
            LimparControle();
            codigo = -1;
        }
        
        public void esconderElementos()
        {
            btn_Alterar.Visible = false;
            btn_Criarnovo.Visible = false;
            btn_Excluir.Visible = false;
            btn_Salvar.Visible = false;
            btn_ListTarefas.Visible = false;
            datagrid_ListTarefas.Visible = false;
            text_Tarefa.Visible = false;
            text_Consequencia.Visible = false;
            text_Recompensa.Visible = false;
            num_nivelConsequencia.Visible = false;
            num_nivelRecompensa.Visible = false;
            num_nivelTarefa.Visible = false;
            mask_data.Visible = false;
            cmbo_Dayweek.Visible = false;
            label_Tarefa.Visible = false;
            label_Consequencia.Visible = false;
            label_Recompensa.Visible = false;
            label_NivelC.Visible = false;
            label_NivelR.Visible = false;
            label_NivelT.Visible = false;
            label_Dayweek.Visible = false;
            label_Data.Visible = false;
        }
        public void mostrarElementos()
        {
            btn_Excluir.Enabled = false;
            btn_Alterar.Enabled = false;

            btn_Alterar.Visible = true;
            btn_Criarnovo.Visible = false;
            btn_Excluir.Visible = true;
            btn_Salvar.Visible = true;
            btn_ListTarefas.Visible = true;
            datagrid_ListTarefas.Visible = true;
            text_Tarefa.Visible = true;
            text_Consequencia.Visible = true;
            text_Recompensa.Visible = true;
            num_nivelConsequencia.Visible = true;
            num_nivelRecompensa.Visible = true;
            num_nivelTarefa.Visible = true;
            mask_data.Visible = true;
            cmbo_Dayweek.Visible = true;
            label_Tarefa.Visible = true;
            label_Consequencia.Visible = true;
            label_Recompensa.Visible = true;
            label_NivelC.Visible = true;
            label_NivelR.Visible = true;
            label_NivelT.Visible = true;
            label_Dayweek.Visible = true;
            label_Data.Visible = true;
        }

        public void esconderAgenda()
        {
            btn_NovaTarefa.Visible = false;
            btn_VerAgenda.Enabled = true;
            label_S.Visible = false;
            label_T.Visible = false;
            label_Q.Visible = false;
            label_Quinta.Visible = false;
            label_Sexta.Visible = false;
            checkedListBox_Segunda.Visible = false;
            checkedListBox_Terca.Visible = false;
            checkedListBox_Quarta.Visible = false;
            checkedListBox_Quinta.Visible = false;
            checkedListBox_Sexta.Visible = false;
        }

           public void mostrarAgenda()
        {
            btn_NovaTarefa.Visible = true;
            btn_VerAgenda.Enabled = false;
            label_S.Visible = true;
            label_T.Visible = true;
            label_Q.Visible = true;
            label_Quinta.Visible = true;
            label_Sexta.Visible = true;
            checkedListBox_Segunda.Visible = true;
            checkedListBox_Terca.Visible = true;
            checkedListBox_Quarta.Visible = true;
            checkedListBox_Quinta.Visible = true;
            checkedListBox_Sexta.Visible = true;

        }

    }
}
