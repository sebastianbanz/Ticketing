import React, { Children } from "react";
import ReactDOM from "react-dom/client";
import ErrorPage from "./error-page";
import Contact, {
    loader as contactLoader,
    action as contactAction,
} from "./routes/contact";
import Root, {
    loader as rootLoader,
    action as rootAction,
} from "./routes/root";
import EditContact, { action as editAction, } from "./routes/edit";

import {
    createBrowserRouter,
    RouterProvider,
    Route,
} from "react-router-dom";
import "./index.css";
import { action as destroyAction } from "./routes/destroy";
import Index from "./routes/Home";


const router = createBrowserRouter([
    {
        path: "/",
        element: <Root />,
        errorElement: <ErrorPage />,
        loader: rootLoader,
        action: rootAction,
        children: [

            {
                errorElement: <ErrorPage />,
                children: [

                    { index: true, element: <Index /> },
                    {

                        path: "contacts/:contactId",
                        element: <Contact />,
                        loader: contactLoader,
                        action: contactAction,
                    },
                    {
                        path: "contacts/:contactId/edit",
                        element: <EditContact />,
                        loader: contactLoader,
                        action: editAction,
                    },
                    {
                        path: "contacts/:contactId/destroy",
                        action: destroyAction,
                    },
                ],
            },
        ],
    },
]);

ReactDOM.createRoot(document.getElementById("root")).render(
    <React.StrictMode>
        <RouterProvider router={router} />
    </React.StrictMode>
);
