using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costazul
{
    public partial class formEditarUsuario : Form
    {
        pila resultados = new pila();
        persona[] arrayCoincidencias;
        persona registroEnEdicion;
        compra[] arrayCompras;
        bool displayCompra = false;

        public formEditarUsuario()
        {
            InitializeComponent();
            this.ClientSize = fondo.Size;
            labelNombre.Parent = fondo;
            labelApellido.Parent = fondo;
            comboBoxTDoc.SelectedIndex = 0;
            panelOpcionesEdicion.Parent = fondo;
        }

        private void radioButtonNA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNA.Checked)
            {
                labelNombre.Visible = true;
                textBoxNombreCI.Visible = true;
                labelApellido.Visible = true;
                textBoxApellido.Visible = true;
                comboBoxTDoc.Visible = false;
                buttonBuscar.Visible = true;
            }
        }

        private void radioButtonCI_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonCI.Checked)
            {
                textBoxNombreCI.Visible = true;
                comboBoxTDoc.Visible = true;
                labelNombre.Visible = false;
                labelApellido.Visible = false;
                textBoxApellido.Visible = false;
                buttonBuscar.Visible = true;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            comboBoxCoincidencias.Items.Clear();
            if(radioButtonNA.Checked)
            {
                bienvenido.personas.buscarPersonaNA(textBoxNombreCI.Text + " " + textBoxApellido.Text, resultados);
            }
            else
            {
                bienvenido.personas.buscarPersonaCI(comboBoxTDoc.SelectedItem.ToString() + textBoxNombreCI.Text, resultados);
            }

            if (!resultados.esVacia())
            {
                panelNotif.Visible = false;
                comboBoxCoincidencias.Visible = true;
                arrayCoincidencias = new persona[resultados.getTamanio()];
                for (int i = 0; i<arrayCoincidencias.Length; i++)
                {
                    arrayCoincidencias[i] = resultados.sacarPersonaDePila();
                    if (arrayCoincidencias[i].getMEntrada() < 10)
                    {
                        comboBoxCoincidencias.Items.Add(arrayCoincidencias[i].getDEntrada() + " " + arrayCoincidencias[i].getHEntrada() + ":0" + arrayCoincidencias[i].getMEntrada());
                    }
                    else
                    {
                        comboBoxCoincidencias.Items.Add(arrayCoincidencias[i].getDEntrada() + " " + arrayCoincidencias[i].getHEntrada() + ":" + arrayCoincidencias[i].getMEntrada());
                    }
                }
                comboBoxCoincidencias.SelectedIndex = 0;
            }
            else
            {
                panelNotif.Visible = true;
                labelNotif.Text = "No se consiguieron resultados.";
            }
        }

        private void buttonInfoPersonal_Click(object sender, EventArgs e)
        {
            panelInfoPersonal.Visible = true;
            panelInfoVehiculo.Visible = false;
            panelInfoCompra.Visible = false;

            textBoxEditarNombre.Text = registroEnEdicion.getNombre();
            textBoxEditarApellido.Text = registroEnEdicion.getApellido();
            comboBoxEditarTCI.SelectedItem = registroEnEdicion.getTci();
            textBoxEditarCI.Text = registroEnEdicion.getCi();
        }

        private void buttonInfoVehiculo_Click(object sender, EventArgs e)
        {
            if (registroEnEdicion.getVehiculo() != null)
            {
                panelNotif.Visible = false;
                panelInfoVehiculo.Visible = true;
                panelInfoPersonal.Visible = false;
                panelInfoCompra.Visible = false;

                comboBoxEditarMarca.SelectedItem = registroEnEdicion.getVehiculo().getMarca();
                comboBoxEditarColor.SelectedItem = registroEnEdicion.getVehiculo().getColor();
                textBoxEditarPlaca.Text = registroEnEdicion.getVehiculo().getPlaca();
            }
            else
            {
                panelNotif.Visible = true;
                labelNotif.Text = "Esta persona no posee vehículo.";
            }
        }

        private void buttonInfoCompra_Click(object sender, EventArgs e)
        {
            if (!registroEnEdicion.getCompras().esVacia())
            {
                panelInfoCompra.Visible = true;
                panelInfoPersonal.Visible = false;
                panelInfoVehiculo.Visible = false;

                bienvenido.tiendas.llenarComboBoxNombre(comboBoxNombresTiendas);
                for (int i = 0; i < registroEnEdicion.getCompras().getTamanio(); i++)
                {
                    comboBoxNCompras.Items.Add((i+1).ToString());
                }
                arrayCompras = registroEnEdicion.getCompras().conseguirArrayCompras();
                comboBoxNCompras.SelectedIndex = 0;
            }
            else
            {
                panelNotif.Visible = true;
                labelNotif.Text = "Esta persona no posee compras.";
            }
            
            
        }

        private void comboBoxCoincidencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelOpcionesEdicion.Visible = true;
            registroEnEdicion = arrayCoincidencias[comboBoxCoincidencias.SelectedIndex];
        }

        private void buttonConfirmarInfoPersonal_Click(object sender, EventArgs e)
        {
            if (formRegistroUsuarios.esLetra(textBoxEditarNombre.Text) && formRegistroUsuarios.esLetra(textBoxEditarApellido.Text) && formRegistroUsuarios.esNumero(textBoxEditarCI.Text))
            {
                registroEnEdicion.setNombre(textBoxEditarNombre.Text);
                registroEnEdicion.setApellido(textBoxEditarApellido.Text);
                registroEnEdicion.setTci(comboBoxEditarTCI.SelectedItem.ToString());
                registroEnEdicion.setCi(textBoxEditarCI.Text);
                bienvenido.personas.modificarInfoPersonal(registroEnEdicion);
                panelNotif.Visible = true;
                labelNotif.Text = "Información actualizada.";
            }
            else
            {
                if (!formRegistroUsuarios.esLetra(textBoxEditarNombre.Text))
                {
                    textBoxEditarNombre.ForeColor = Color.Red;
                }
                else
                {
                    textBoxEditarNombre.ForeColor = Color.Black;
                }

                if (!formRegistroUsuarios.esLetra(textBoxEditarApellido.Text))
                {
                    textBoxEditarApellido.ForeColor = Color.Red;
                }
                else
                {
                    textBoxEditarApellido.ForeColor = Color.Black;
                }

                if (!formRegistroUsuarios.esNumero(textBoxEditarCI.Text))
                {
                    textBoxEditarCI.ForeColor = Color.Red;
                }
                else
                {
                    textBoxEditarCI.ForeColor = Color.Black;
                }
            }
        }

        private void buttonRegresarInfoPersonal_Click(object sender, EventArgs e)
        {
            panelInfoPersonal.Visible = false;
            panelNotif.Visible = false;
        }

        private void buttonRegresarAMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formEditarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            bienvenido b = new bienvenido();
            b.Show();
        }

        private void buttonConfirmarInfoVehiculo_Click(object sender, EventArgs e)
        {
            if (formRegistroUsuarios.placaValida(textBoxEditarPlaca.Text))
            {
                textBoxEditarPlaca.ForeColor = Color.Black;
                registroEnEdicion.getVehiculo().setMarca(comboBoxEditarMarca.SelectedItem.ToString());
                registroEnEdicion.getVehiculo().setColor(comboBoxEditarColor.SelectedItem.ToString());
                registroEnEdicion.getVehiculo().setPlaca(textBoxEditarPlaca.Text);

                bool found = false;
                if (registroEnEdicion.getVehiculo().getTipo().Equals("Moto"))
                {
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j<100; j++)
                        {
                            if (bienvenido.sectoresMotos[i, j].getOcupantes().existeIDOcupante(registroEnEdicion.getVehiculo().getID()))
                            {
                                bienvenido.sectoresMotos[i, j].getOcupantes().modificarInfoVehiculo(registroEnEdicion.getVehiculo());
                                found = true;
                                break;
                            }
                            if (found)
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
                            if (bienvenido.sectoresCarros[i, j].getOcupantes().existeIDOcupante(registroEnEdicion.getVehiculo().getID()))
                            {
                                bienvenido.sectoresCarros[i, j].getOcupantes().modificarInfoVehiculo(registroEnEdicion.getVehiculo());
                                found = true;
                                break;
                            }
                            if (found)
                            {
                                break;
                            }
                        }
                    }
                }
                panelNotif.Visible = true;
                labelNotif.Text = "Información actualizada.";
            }
            else
            {
                textBoxEditarPlaca.ForeColor = Color.Red;
            }
        }

        private void buttonRegresarInfoVehiculo_Click(object sender, EventArgs e)
        {
            panelInfoVehiculo.Visible = false;
            panelNotif.Visible = false;
        }

        private void comboBoxNCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayCompra = true;
            comboBoxNombresTiendas.SelectedItem = arrayCompras[comboBoxNCompras.SelectedIndex].getTienda().getNombre();
            numericUpDownUnidades.Value = arrayCompras[comboBoxNCompras.SelectedIndex].getUnidades();
            if (arrayCompras[comboBoxNCompras.SelectedIndex].getTipoCompra().Equals("Online"))
            {
                radioButtonOnline.Checked = true;
            }
            else
            {
                radioButtonPresencial.Checked = true;
            }
            comboBoxMPago.SelectedItem = arrayCompras[comboBoxNCompras.SelectedIndex].getMetodoPago();
        }

        private void comboBoxNombresTiendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxProductos.Items.Clear();
            bienvenido.tiendas.buscarTiendaNombre(comboBoxNombresTiendas.SelectedItem.ToString()).getProductos().llenarComboBoxProductos(comboBoxProductos);
            if (displayCompra)
            {
                comboBoxProductos.SelectedItem = arrayCompras[comboBoxNCompras.SelectedIndex].getProducto().getNombre();
                displayCompra = false;
            }
        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            double precio = bienvenido.tiendas.buscarTiendaNombre(comboBoxNombresTiendas.SelectedItem.ToString()).getProductos().buscarProducto(comboBoxProductos.SelectedItem.ToString()).getPrecio();
            labelPrecio.Text = "Precio: " + precio + "$";
            labelPTotal.Text = "Precio total: " + precio * (double)numericUpDownUnidades.Value + "$";
        }

        private void numericUpDownUnidades_ValueChanged(object sender, EventArgs e)
        {
            double precio = bienvenido.tiendas.buscarTiendaNombre(comboBoxNombresTiendas.SelectedItem.ToString()).getProductos().buscarProducto(comboBoxProductos.SelectedItem.ToString()).getPrecio();
            labelPTotal.Text = "Precio total: " + precio * (double)numericUpDownUnidades.Value + "$";
        }

        private void radioButtonOnline_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMPago.Items.Clear();
            if (radioButtonOnline.Checked)
            {
                comboBoxMPago.Items.Add("Zelle");
                comboBoxMPago.Items.Add("Pago Móvil");
                comboBoxMPago.Items.Add("Transferencia");
            }
        }

        private void radioButtonPresencial_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMPago.Items.Clear();
            if (radioButtonPresencial.Checked)
            {
                comboBoxMPago.Items.Add("Efectivo");
                comboBoxMPago.Items.Add("TDD");
                comboBoxMPago.Items.Add("TDC");
            }
        }

        private void buttonConfirmarInfoCompra_Click(object sender, EventArgs e)
        {
            if (comboBoxNCompras.SelectedIndex > -1)
            {
                compra compraEditada = arrayCompras[comboBoxNCompras.SelectedIndex];
                compraEditada.setTienda(bienvenido.tiendas.buscarTiendaNombre(comboBoxNombresTiendas.SelectedItem.ToString()));
                compraEditada.setProducto(compraEditada.getTienda().getProductos().buscarProducto(comboBoxProductos.SelectedItem.ToString()));
                compraEditada.setUnidades((int)numericUpDownUnidades.Value);
                compraEditada.setPrecioTotal(bienvenido.tiendas.buscarTiendaNombre(comboBoxNombresTiendas.SelectedItem.ToString()).getProductos().buscarProducto(comboBoxProductos.SelectedItem.ToString()).getPrecio() * (double)numericUpDownUnidades.Value);
                if (radioButtonOnline.Checked)
                {
                    compraEditada.setTipoCompra("Online");
                }
                else
                {
                    compraEditada.setTipoCompra("Presencial");
                }
                compraEditada.setMetodoPago(comboBoxMPago.SelectedItem.ToString());

                registroEnEdicion.getCompras().modificarInfoCompra(arrayCompras[comboBoxNCompras.SelectedIndex], compraEditada);
                panelNotif.Visible = true;
                labelNotif.Text = "Información actualizada.";
            }
            else
            {
                panelNotif.Visible = true;
                labelNotif.Text = "No ha seleccionado una compra.";
            }
        }

        private void buttonRegresarInfoCompra_Click(object sender, EventArgs e)
        {
            panelInfoCompra.Visible = false;
            panelNotif.Visible = false;
        }
    }
}