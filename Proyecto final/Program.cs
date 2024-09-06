using System;


class Proyecto
{
    static void Main()
    {


        Console.WriteLine("Bienvenido al programa de ventas de Celulares");

        List<string> listaProductos = new List<string>();
        List<double> listaPrecios = new List<double>();

        int opcionPrincipal;
        do
        {
            Console.WriteLine("Bienvenido al programa de ventas de Celulares en Tegucigalpa");
            Console.Clear();
            Console.WriteLine("=== ventas varias ===");
            Console.WriteLine("1. Iphone ");
            Console.WriteLine("2. Samsung");
            Console.WriteLine("3. Xiaomi");
            Console.WriteLine("4. Realme");
            Console.WriteLine("5. Salir");
            Console.WriteLine("=======================");
            Console.Write("Seleccione una opcion: ");

            opcionPrincipal = int.Parse(Console.ReadLine());

            switch (opcionPrincipal)
            {
                case 1:

                    int Iphone;
                    do
                    {
                        Console.WriteLine("celulares Iphone Disponibles en nuestra tienda");
                        Console.WriteLine("1. Iphone 11 pro max 10,000 Lps");
                        Console.WriteLine("2. IPhone 11 Pro 7,000 Lps ");
                        Console.WriteLine("3. IPhone 12 mini 15,000 Lps");
                        Console.WriteLine("4. IPhone 12 12,000 Lps");
                        Console.WriteLine("5. IPhone 12 Pro Max 12,000 Lps");
                        Console.WriteLine("6. IPhone 13 mini 7,000 Lps");
                        Console.WriteLine("7. IPhone XR 15,000 Lps");
                        Console.WriteLine("8. IPhone X 13,000 Lps");
                        Console.WriteLine("9. IPhone 8 Plus 14,000 Lps");
                        Console.WriteLine("10. Regresar al menu principal");
                        Console.Write("Seleccione un producto: ");
                        Iphone = int.Parse(Console.ReadLine());

                        double Costo = 0;
                        double impuesto = 0;

                        switch (Iphone)
                        {
                            case 1:
                                Costo = 10000;
                                impuesto = 0.19;
                                break;
                            case 2:
                                Costo = 7000;
                                impuesto = 0.19;
                                break;
                            case 3:
                                Costo = 15000;
                                impuesto = 0.10;
                                break;
                            case 4:
                                Costo = 12000;
                                impuesto = 0.10;
                                break;

                            case 5:
                                Costo = 12000;
                                impuesto = 0.18;
                                break;
                            case 6:
                                Costo = 7000;
                                impuesto = 0.1;
                                break;
                            case 7:
                                Costo = 15000;
                                impuesto = 0.2;
                                break;
                            case 8:
                                Costo = 13000;
                                impuesto = 0.18;
                                break;

                            case 9:
                                Costo = 14000;
                                impuesto = 0.2;
                                break;
                            case 10:

                                Console.WriteLine("Regresando al menú principal...");
                                break;

                            default:
                                Console.WriteLine("Opcion no valida Porfavor intentelo de nuevo");
                                continue;
                        }

                        if (Iphone >= 1 && Iphone <= 9)
                        {
                            Console.Write("Ingresa la cantidad que deseas adquirir. NO PUEDE SOBREPASAR LOS 100 ARTICULOS: ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 100)
                            {
                                Console.WriteLine("Intente de nuevo la cantidad no puede superar 100 Dispositivos ");
                                continue;
                            }

                            double precioConImpuesto = Costo + (Costo * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;


                            listaProductos.Add($"{(Iphone == 1 ? "Iphone 11 pro max " : Iphone == 2 ? "IPhone 11 Pro" : Iphone == 3 ? "IPhone 12 mini " : Iphone == 4 ? "IPhone 12 " : Iphone == 5 ? "IPhone 12 Pro Max " : Iphone == 6 ? "IPhone 13 mini" : Iphone == 7 ? "IPhone XR " : Iphone == 8 ? "IPhone X " : Iphone == 9 ? "IPhone 8 Plus" : "")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: {precioConImpuesto:F2} Lps");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: {precioFinal:F2} Lps");


                            Console.WriteLine("continuar viendo el inventario? ");
                            Console.WriteLine("1. si");
                            Console.WriteLine("2. no ");

                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "si")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (Iphone != 10);
                    break;

                case 2:

                    int Samsung;
                    do
                    {
                        Console.WriteLine("celulares Samsung Disponibles en nuestra tienda");
                        Console.WriteLine("1. Samsung Galaxy S24 Ultra 17,000 Lps");
                        Console.WriteLine("2. Samsung Galaxy S21 Ultra 15,000 Lps ");
                        Console.WriteLine("3. Samsung Galaxy S21 12,000 Lps");
                        Console.WriteLine("4. Samsung Galaxy S22+ 13,000 Lps");
                        Console.WriteLine("5. Samsung Galaxy S21 FE 9,000 Lps");
                        Console.WriteLine("6. Samsung Galaxy S23 Ultra 11,500 Lps");
                        Console.WriteLine("7. Samsung Galaxy S23 Ultra 14,800 Lps");
                        Console.WriteLine("8. Samsung Galaxy A55 16,500 Lps");
                        Console.WriteLine("9. Samsung Galaxy A34 15,700 Lps");
                        Console.WriteLine("10. Regresar al menu principal");
                        Console.Write("Seleccione un producto: ");
                        Samsung = int.Parse(Console.ReadLine());

                        double Costo = 0;
                        double impuesto = 0;

                        switch (Samsung)
                        {
                            case 1:
                                Costo = 17000;
                                impuesto = 0.13;
                                break;
                            case 2:
                                Costo = 15000;
                                impuesto = 0.19;
                                break;
                            case 3:
                                Costo = 12000;
                                impuesto = 0.10;
                                break;
                            case 4:
                                Costo = 13000;
                                impuesto = 0.10;
                                break;

                            case 5:
                                Costo = 9000;
                                impuesto = 0.8;
                                break;
                            case 6:
                                Costo = 11500;
                                impuesto = 0.4;
                                break;
                            case 7:
                                Costo = 14800;
                                impuesto = 0.9;
                                break;
                            case 8:
                                Costo = 16500;
                                impuesto = 0.12;
                                break;

                            case 9:
                                Costo = 15700;
                                impuesto = 0.15;
                                break;
                            case 10:

                                Console.WriteLine("Regresando al menú principal...");
                                break;

                            default:
                                Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                                continue;
                        }

                        if (Samsung >= 1 && Samsung <= 9)
                        {
                            Console.Write("Ingresa la cantidad que deseas adquirir. NO PUEDE SOBREPASAR LOS 100 ARTICULOS: ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 100)

                            {
                                Console.WriteLine("Intente de nuevo la cantidad no puede superar 100 Dispositivos ");
                                continue;
                            }

                            double precioConImpuesto = Costo + (Costo * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;


                            listaProductos.Add($"{(Samsung == 1 ? "Samsung Galaxy S24 Ultra " : Samsung == 2 ? "Samsung Galaxy S21 Ultra" : Samsung == 3 ? "Samsung Galaxy S21  " : Samsung == 4 ? "Samsung Galaxy S22+" : Samsung == 5 ? "Samsung Galaxy S21 FE" : Samsung == 6 ? "Samsung Galaxy S23 Ultra " : Samsung == 7 ? "Samsung Galaxy S23 Ultra " : Samsung == 8 ? "Samsung Galaxy A55 " : Samsung == 9 ? "Samsung Galaxy A34" : "")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: {precioConImpuesto:F2} Lps");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: {precioFinal:F2} Lps");


                            Console.WriteLine("continuar viendo el inventario? ");
                            Console.WriteLine("1. si");
                            Console.WriteLine("2. no ");

                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "si")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (Samsung != 10);
                    break;



                case 3:

                    int Xiaomi;
                    do
                    {
                        Console.WriteLine("celulares Xiaomi Disponibles en nuestra tienda");
                        Console.WriteLine("1. Xiaomi Redmi Note 10 Azul 128GB 12,000 Lps");
                        Console.WriteLine("2. Xiaomi Poco X5 Negro 256GB 13,500 Lps");
                        Console.WriteLine("3. Xiaomi Redmi Note 12 Gris 128GB 14,800 Lps");
                        Console.WriteLine("4. Xiaomi Redmi Note 12 Azul 128GB 14,650 Lps");
                        Console.WriteLine("5. Xiaomi Redmi 12C Gris 128GB 11,000 Lps");
                        Console.WriteLine("6. Xiaomi Redmi 12C Gris 64GB 11,200 Lps");
                        Console.WriteLine("7. Xiaomi Redmi 10A Azul 32GB 10,999 Lps");
                        Console.WriteLine("8. Xiaomi 13 Lite 32GB 13,000 Lps");
                        Console.WriteLine("9. Xiaomi POCO F5 128GB 9,800 Lps");
                        Console.WriteLine("10. Regresar al menu principal");
                        Console.Write("Seleccione un producto: ");
                        Xiaomi = int.Parse(Console.ReadLine());

                        double Costo = 0;
                        double impuesto = 0;

                        switch (Xiaomi)
                        {
                            case 1:
                                Costo = 12000;
                                impuesto = 0.13;
                                break;
                            case 2:
                                Costo = 13500;
                                impuesto = 0.19;
                                break;
                            case 3:
                                Costo = 14800;
                                impuesto = 0.10;
                                break;
                            case 4:
                                Costo = 14650;
                                impuesto = 0.10;
                                break;

                            case 5:
                                Costo = 11000;
                                impuesto = 0.8;
                                break;
                            case 6:
                                Costo = 11200;
                                impuesto = 0.4;
                                break;
                            case 7:
                                Costo = 10999;
                                impuesto = 0.9;
                                break;
                            case 8:
                                Costo = 13000;
                                impuesto = 0.12;
                                break;

                            case 9:
                                Costo = 9800;
                                impuesto = 0.15;
                                break;
                            case 10:

                                Console.WriteLine("Regresando al menú principal...");
                                break;

                            default:
                                Console.WriteLine("Opcion no valida Porfavor intentelo de nuevo.");
                                continue;
                        }

                        if (Xiaomi >= 1 && Xiaomi <= 9)
                        {
                            Console.Write("Ingresa la cantidad que deseas adquirir. NO PUEDE SOBREPASAR LOS 100 ARTICULOS: ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 100)
                            {
                                Console.WriteLine("Intente de nuevo la cantidad no puede superar 100 Dispositivos ");
                                continue;
                            }

                            double precioConImpuesto = Costo + (Costo * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;


                            listaProductos.Add($"{(Xiaomi == 1 ? "Xiaomi Redmi Note 10 Azul 128GB" : Xiaomi == 2 ? "Xiaomi Poco X5 Negro 256GB " : Xiaomi == 3 ? " Xiaomi Redmi Note 12 Gris 128GB " : Xiaomi == 4 ? "Xiaomi Redmi Note 12 Azul 128GB" : Xiaomi == 5 ? "Xiaomi Redmi 12C Gris 128GB" : Xiaomi == 6 ? "Xiaomi Redmi 12C Gris 64GB " : Xiaomi == 7 ? "Xiaomi Redmi 10A Azul 32GB " : Xiaomi == 8 ? "Xiaomi 13 Lite 32GB " : Xiaomi == 9 ? "Xiaomi POCO F5 128GB" : "")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: {precioConImpuesto:F2} Lps");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: {precioFinal:F2} Lps");


                            Console.WriteLine("continuar viendo el inventario? ");
                            Console.WriteLine("1. si");
                            Console.WriteLine("2. no ");

                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "si")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (Xiaomi != 10);
                    break;
                
                case 4:
                    int Realme;
                    do
                    {
                        Console.WriteLine("celulares Realme Disponibles en nuestra tienda");
                        Console.WriteLine("1.  realme 12 11,700 Lps");
                        Console.WriteLine("2.  realme C65 12,500 Lps");
                        Console.WriteLine("3.  realme GT 6 11,800 Lps");
                        Console.WriteLine("4.  realme GT 6T 14,950 Lps");
                        Console.WriteLine("5.  realme 12 5G 14,000 Lps");
                        Console.WriteLine("6.  realme 12+ 5G 11,200 Lps");
                        Console.WriteLine("7.  realme 12 Pro 5G 12,999 Lps");
                        Console.WriteLine("8.  realme Note 50 13,000 Lps");
                        Console.WriteLine("9.  realme 13 Pro 10,800 Lps");
                        Console.WriteLine("10. Regresar al menu principal");
                        Console.Write("Seleccione un producto: ");
                        Realme = int.Parse(Console.ReadLine());

                        double Costo = 0;
                        double impuesto = 0;

                        switch (Realme)
                        {
                            case 1:
                                Costo = 11700;
                                impuesto = 0.23;
                                break;
                            case 2:
                                Costo = 12500;
                                impuesto = 0.18;
                                break;
                            case 3:
                                Costo = 11800;
                                impuesto = 0.10;
                                break;
                            case 4:
                                Costo = 14950;
                                impuesto = 0.18;
                                break;

                            case 5:
                                Costo = 14000;
                                impuesto = 0.16;
                                break;
                            case 6:
                                Costo = 12900;
                                impuesto = 0.12;
                                break;
                            case 7:
                                Costo = 10999;
                                impuesto = 0.15;
                                break;
                            case 8:
                                Costo = 13000;
                                impuesto = 0.19;
                                break;

                            case 9:
                                Costo = 10800;
                                impuesto = 0.10;
                                break;
                            case 10:

                                Console.WriteLine("Regresando al menú principal...");
                                break;

                            default:
                                Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                                continue;
                        }

                        if (Realme >= 1 && Realme <= 9)
                        {
                            Console.Write("Ingresa la cantidad que deseas adquirir. NO PUEDE SOBREPASAR LOS 100 ARTICULOS: ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 100)
                            {
                                Console.WriteLine("Intente de nuevo la cantidad no puede superar 100 Dispositivos ");
                                continue;
                            }

                            double precioConImpuesto = Costo + (Costo * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;


                            listaProductos.Add($"{(Realme == 1 ? " realme 12 " : Realme == 2 ? " realme C65" : Realme == 3 ? "realme GT 6 " : Realme == 4 ? "realme GT 6T" : Realme == 5 ? "realme 12 5G" : Realme  == 6 ? " realme 12+ 5G" : Realme == 7 ? "realme 12 Pro 5G " : Realme == 8 ? "realme Note 50 " : Realme == 9 ? "realme 13 Pro" : "")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: {precioConImpuesto:F2} Lps");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: {precioFinal:F2} Lps");


                            Console.WriteLine("continuar viendo el inventario? ");
                            Console.WriteLine("1. si");
                            Console.WriteLine("2. no ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "si ")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (Realme != 10);
                    break;
               
                case 5:

                    Console.WriteLine("Generando factura final...");
                    MostrarFacturaFinal(listaProductos, listaPrecios);
                    break;

                default:

                    Console.WriteLine("Opción inválida, por favor intente de nuevo.");
                    break;
            }

        } while (opcionPrincipal != 3);
    }


    static double CalcularDescuento(int cantidad)
    {
        if (cantidad >= 50)
        {
            return 0.15;
        }
        else if (cantidad >= 20)
        {
            return 0.10;
        }
        else if (cantidad >= 10)
        {
            return 0.05;
        }
        else
        {
            return 0;
        }
    }


    static void MostrarFacturaFinal(List<string> listaProductos, List<double> listaPrecios)
    {
      
        double total = 0;

        for (int i = 0; i < listaProductos.Count; i++)
        {
            Console.WriteLine($"{listaProductos[i]} - {listaPrecios[i]:F2} Lps");
            total += listaPrecios[i];
        }

        Console.WriteLine($"Gracias por su compra");
        Console.WriteLine($"A gastado: {total:F2} Lps");
   
    }
}